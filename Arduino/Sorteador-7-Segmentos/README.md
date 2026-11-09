# Sorteador de números com display de 7 segmentos

Projeto em **Arduino/C++** que exibe números aleatórios rapidamente no display e permite interromper a animação para mostrar o número sorteado (0 a 9). Baseado nos exemplos de botão e display fornecidos na aula.

## Demonstração (GIF no README)

![GIF ilustrativo da animação e do sorteio](assets/demonstracao-sorteador.gif)

> O GIF é uma **representação visual dos estados**, não uma gravação de uma montagem real. Para comprovar a execução do sistema, grave o Arduino físico ou uma captura da simulação seguindo o roteiro de teste abaixo.

## Integrantes

- Arthur Henrique Abreu
- **[Adicionar demais integrantes do grupo, caso existam]**

## Materiais

- Arduino Uno R3
- Display de 7 segmentos de **cátodo comum**, um dígito
- 2 botões push-button
- **7 resistores de 220 Ω a 330 Ω**, um por segmento
- Protoboard, jumpers e cabo USB

## Montagem (pinos Arduino)

| Elemento | Pino | Ligação |
| --- | --- | --- |
| Segmento A | D2 | D2 → resistor → A |
| Segmento B | D3 | D3 → resistor → B |
| Segmento C | D4 | D4 → resistor → C |
| Segmento D | D5 | D5 → resistor → D |
| Segmento E | D6 | D6 → resistor → E |
| Segmento F | D7 | D7 → resistor → F |
| Segmento G | D8 | D8 → resistor → G |
| Terminal COM | GND | Comum do display no GND |
| Botão 1 (iniciar/desligar) | D9 | D9 → botão → GND |
| Botão 2 (sortear/parar) | D10 | D10 → botão → GND |

O ponto decimal (DP) não é usado. O código utiliza **INPUT_PULLUP**, com leitura LOW quando pressionado; não requer resistor externo de pull-up. Confirme a pinagem real do modelo de display antes de montar. Caso seja **ânodo comum**, conecte o COM a 5 V e altere COMMON_ANODE para true.

**Segurança elétrica:** use um resistor por segmento; não confie no resistor único do exemplo de aula para limitar corretamente a corrente de cada LED.

## Descrição técnica

A lógica usa três estados: **OFF** (apagado), **ANIMATING** (mudança de número a cada 65 ms) e **RESULT** (número congelado). O botão 1 inicia quando está desligado e desliga quando está ligado; o botão 2 só funciona durante a animação.

A função displayDigit() utiliza máscaras de bits para acionar os sete segmentos. O loop() usa **millis()**, sem delay() bloqueante, e debounce de 30 ms em ambos os botões. Ao pressionar SORTEAR, random(0, 10) gera o número final. A semente combina analogRead(A0) e micros(): é pseudoaleatoriedade, adequada à atividade didática, não para criptografia.

### Fluxo de operação

1. Ao energizar: display apagado.
2. Pressione o botão em D9: a animação começa.
3. Pressione o botão em D10: um número entre 0 e 9 é sorteado e permanece visível.
4. Pressione D9: display apaga.
5. Pressione D9 e depois D10 para executar outro sorteio.

## Arquivos

- **sorteador_7_segmentos/sorteador_7_segmentos.ino:** código principal para Arduino IDE.
- **wokwi/sketch.ino:** mesmo programa para o simulador Wokwi.
- **wokwi/diagram.json:** Arduino Uno, display, dois botões e sete resistores.
- **assets/demonstracao-sorteador.gif:** GIF incorporado acima.

## Executar no Arduino físico

Abra o arquivo sorteador_7_segmentos/sorteador_7_segmentos.ino na [Arduino IDE](https://www.arduino.cc/en/software), escolha a placa Arduino Uno e a porta USB, monte o circuito conforme a tabela e clique em Carregar. O Monitor Serial pode ser aberto em **9600 baud**.

## Simular no Wokwi

Abra [um projeto Arduino Uno no Wokwi](https://wokwi.com/projects/new/arduino-uno). Substitua o código de sketch.ino pelo conteúdo de **wokwi/sketch.ino** e o diagrama pelo conteúdo de **wokwi/diagram.json**. Clique Play. Botão verde = **INICIAR / DESLIGAR** (tecla I); botão azul = **SORTEAR** (tecla S).

O formato do diagrama e os pinos utilizados seguem a [documentação oficial do Wokwi](https://docs.wokwi.com/diagram-format).

## Roteiro para o vídeo de entrega

Mostre o display inicialmente apagado; pressione Iniciar; mostre os números alternando rapidamente; pressione Sortear; mostre o resultado fixo; pressione Iniciar/Desligar para apagar; repita um segundo sorteio. Você pode gravar a tela do Wokwi ou o circuito físico.

## Referências da aula

Exemplos: **07_botao_led.zip** e **08_display_7_segmentos.zip**. Foram reaproveitados os segmentos nos pinos D2–D8, adicionando os botões em D9 e D10, máquina de estados, sorteio e debounce.
