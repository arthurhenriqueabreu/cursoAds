/*
  SORTEADOR DE NUMEROS (0 A 9)
  Arduino Uno, display catodo comum e dois botoes.
  Segmentos A-G: pinos D2 a D8, cada um com resistor de 220-330 ohms.
  Botao INICIAR/DESLIGAR: D9 -> botao -> GND.
  Botao SORTEAR/PARAR: D10 -> botao -> GND.
*/
#include <Arduino.h>
const uint8_t SEGMENT_PINS[7] = {2, 3, 4, 5, 6, 7, 8};
const uint8_t BUTTON_POWER_PIN = 9;
const uint8_t BUTTON_DRAW_PIN = 10;
const bool COMMON_ANODE = false;
const unsigned long ANIMATION_INTERVAL_MS = 65UL;
const unsigned long DEBOUNCE_MS = 30UL;

// Bits 0..6 = segmentos A..G
const uint8_t DIGIT_MASKS[10] = {
  0b00111111, // 0
  0b00000110, // 1
  0b01011011, // 2
  0b01001111, // 3
  0b01100110, // 4
  0b01101101, // 5
  0b01111101, // 6
  0b00000111, // 7
  0b01111111, // 8
  0b01101111  // 9
};

enum State { OFF, ANIMATING, RESULT };
State state = OFF;
uint8_t currentDigit = 0;
unsigned long lastAnimationTime = 0;

struct Button {
  uint8_t pin;
  bool lastRaw;
  bool stable;
  unsigned long changedAt;
};
Button powerButton = {BUTTON_POWER_PIN, HIGH, HIGH, 0};
Button drawButton = {BUTTON_DRAW_PIN, HIGH, HIGH, 0};

void writeSegment(uint8_t index, bool illuminated) {
  const bool outputHigh = COMMON_ANODE ? !illuminated : illuminated;
  digitalWrite(SEGMENT_PINS[index], outputHigh ? HIGH : LOW);
}

void clearDisplay() {
  for (uint8_t i = 0; i < 7; ++i) writeSegment(i, false);
}

void displayDigit(uint8_t digit) {
  if (digit > 9) return;
  for (uint8_t i = 0; i < 7; ++i) {
    const bool on = (DIGIT_MASKS[digit] & (1 << i)) != 0;
    writeSegment(i, on);
  }
}

void onPowerPressed() {
  if (state == OFF) {
    state = ANIMATING;
    currentDigit = (uint8_t) random(0, 10);
    displayDigit(currentDigit);
    lastAnimationTime = millis();
    Serial.println(F("Sorteio iniciado"));
  } else {
    state = OFF;
    clearDisplay();
    Serial.println(F("Display desligado"));
  }
}

void onDrawPressed() {
  if (state != ANIMATING) return;
  currentDigit = (uint8_t) random(0, 10);
  state = RESULT;
  displayDigit(currentDigit);
  Serial.print(F("Numero sorteado: "));
  Serial.println(currentDigit);
}

// Debounce sem delay: gera um evento somente por pressionamento.
bool pressed(Button &button, unsigned long now) {
  const bool raw = digitalRead(button.pin);
  if (raw != button.lastRaw) {
    button.lastRaw = raw;
    button.changedAt = now;
  }
  if ((unsigned long)(now - button.changedAt) >= DEBOUNCE_MS
      && raw != button.stable) {
    button.stable = raw;
    if (raw == LOW) return true;
  }
  return false;
}

void setup() {
  Serial.begin(9600);
  for (uint8_t i = 0; i < 7; ++i) pinMode(SEGMENT_PINS[i], OUTPUT);
  clearDisplay();

  pinMode(BUTTON_POWER_PIN, INPUT_PULLUP);
  pinMode(BUTTON_DRAW_PIN, INPUT_PULLUP);
  powerButton.lastRaw = powerButton.stable = digitalRead(BUTTON_POWER_PIN);
  drawButton.lastRaw = drawButton.stable = digitalRead(BUTTON_DRAW_PIN);
  powerButton.changedAt = drawButton.changedAt = millis();
  randomSeed(((unsigned long)analogRead(A0) << 16) ^ micros());
  Serial.println(F("Pressione D9 para iniciar"));
}

void loop() {
  const unsigned long now = millis();
  if (pressed(powerButton, now)) onPowerPressed();
  if (pressed(drawButton, now)) onDrawPressed();

  if (state == ANIMATING
      && (unsigned long)(now - lastAnimationTime) >= ANIMATION_INTERVAL_MS) {
    lastAnimationTime = now;
    currentDigit = (uint8_t)random(0, 10);
    displayDigit(currentDigit);
  }
}
