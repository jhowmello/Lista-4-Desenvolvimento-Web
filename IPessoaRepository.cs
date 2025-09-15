using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public interface IPessoaRepository
    {
        public List<PessoaDTO> ObterTodos();
        public PessoaDTO ObterPorCpf(string cpf);
        public void Adicionar(PessoaDTO novaPessoa);
        public void Atualizar(string cpf, PessoaDTO pessoaAtualizada);
        public void Remover(string cpf);
    }
}
