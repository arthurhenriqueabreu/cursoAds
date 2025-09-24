public class Receita {
    private int idReceita;
    private String titulo, descricao, caminhoImagem;

    public void definirReceita(int idReceita, String titulo, String descricao, String caminhoImagem){
        this.idReceita = idReceita;
        this.titulo = titulo;
        this.descricao = descricao;
        this.caminhoImagem = caminhoImagem;
    }

        public int getIdReceita() {
        return idReceita;
    }

    public String getTitulo() {
        return titulo;
    }

    public String getDescricao() {
        return descricao;
    }

    public String getCaminhoImagem() {
        return caminhoImagem;
    }
}