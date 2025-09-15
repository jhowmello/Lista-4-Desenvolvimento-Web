using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private static List<PessoaDTO> pessoas = new List<PessoaDTO>();

        public List<PessoaDTO> ObterTodos()
        {
            return pessoas;
        }   
        public PessoaDTO ObterPorCpf(string cpf)
        {
            return pessoas.FirstOrDefault(p => p.cpf == cpf);
        }
        public void Adicionar(PessoaDTO novaPessoa)
        {
            pessoas.Add(novaPessoa);
        }
        public void Atualizar(string cpf, PessoaDTO pessoaAtualizada)
        {
            var pessoa = ObterPorCpf(cpf);
            if (pessoa != null)
            {
                pessoa.nome = pessoaAtualizada.nome;
                pessoa.cpf = pessoaAtualizada.cpf;
                pessoa.peso = pessoaAtualizada.peso;
                pessoa.altura = pessoaAtualizada.altura;
            }
        }
        public void Remover(string cpf)
        {
            var pessoa = ObterPorCpf(cpf);
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
            }
        }
    }

    
}
