# Exercícios - Orientação a Objetos, Coleções e LINQ

Bem-vindo(a) aos exercícios práticos de Orientação a Objetos, Coleções e LINQ em C#! Estes exercícios foram desenvolvidos para reforçar os conceitos aprendidos nos cursos sobre classes, herança, encapsulamento, polimorfismo, strings, coleções e LINQ.

## 📋 Instruções Gerais

- Resolva os exercícios na ordem apresentada
- Teste seu código com diferentes valores de entrada
- Em caso de dúvidas, revise os materiais dos cursos
- Crie um repositório no Git
- No README do projeto adicione estas instruções
- Para cada exercício deve ser criado um pull request e submetido para revisão da equipe

---

## Exercício 1: Sistema de Contas Bancárias (Classes e Encapsulamento)

**Objetivo:** Praticar classes, propriedades, encapsulamento e métodos básicos.
**Descrição:** Crie um sistema de conta bancária com as seguintes classes:

**Classe `ContaBancaria`:**
- Propriedades:
  - `Numero` (string, somente leitura após criação)
  - `Titular` (string)
  - `Saldo` (decimal, privado)
  - `DataAbertura` (DateTime, somente leitura)
- Métodos:
  - `Depositar(decimal valor)`: adiciona valor ao saldo
  - `Sacar(decimal valor)`: remove valor do saldo (validar se tem saldo suficiente)
  - `ObterSaldo()`: retorna o saldo
  - `GerarExtrato()`: retorna uma string formatada com informações da conta

O programa deve:
- Criar múltiplas contas
- Realizar operações de depósito e saque
- Exibir o extrato de cada conta
- Validar operações inválidas (saque maior que saldo, valores negativos)

**Exemplo de saída:**
```
=== EXTRATO DA CONTA ===
Número: 001
Titular: João Silva
Saldo: R$ 1.500,00
Data de Abertura: 06/04/2024
```

## Exercício 2: Sistema de Funcionários com Herança

**Objetivo:** Praticar herança, sobrescrita de métodos e polimorfismo básico.
**Descrição:** Crie um sistema de gerenciamento de funcionários com herança de classes:

**Classe Base `Funcionario`:**
- Propriedades:
  - `Nome`
  - `CPF` (único)
  - `Salario`
  - `DataAdmissao`
- Métodos:
  - `CalcularBonus()`: virtual (será sobrescrito)
  - `ExibirInfo()`: exibe informações do funcionário

**Classes Derivadas:**
1. `Gerente` (herda de `Funcionario`):
   - Propriedade adicional: `NumeroFuncionariosGerenciados`
   - Sobrescrever `CalcularBonus()`: retorna 20% do salário

2. `Developer` (herda de `Funcionario`):
   - Propriedade adicional: `Linguagem` (string)
   - Sobrescrever `CalcularBonus()`: retorna 15% do salário

3. `Estagiario` (herda de `Funcionario`):
   - Propriedade adicional: `Universidade` (string)
   - Sobrescrever `CalcularBonus()`: retorna 5% do salário

O programa deve:
- Criar funcionários de diferentes tipos
- Armazenar em uma lista
- Calcular o bônus de cada um
- Exibir relatório de todos os funcionários com seus respectivos bônus

**Exemplo de saída:**
```
=== RELATÓRIO DE FUNCIONÁRIOS ===
Nome: João Silva | Cargo: Gerente | Salário: R$ 5.000,00 | Bônus: R$ 1.000,00
Nome: Maria Santos | Cargo: Developer | Salário: R$ 4.000,00 | Bônus: R$ 600,00
Nome: Pedro Junior | Cargo: Estagiário | Salário: R$ 1.500,00 | Bônus: R$ 75,00
Total de Funcionários: 3
```

## Exercício 3: Sistema de Biblioteca com Polimorfismo

**Objetivo:** Praticar interfaces, polimorfismo avançado e abstração.
**Descrição:** Crie um sistema de biblioteca com suporte a diferentes tipos de materiais:

**Interface `IMaterial`:**
```csharp
public interface IMaterial
{
    string ObterTitulo();
    string ObterAutor();
    bool EstaDisponivel();
    void Emprestar();
    void Devolver();
    string ObterInfo();
}
```

**Classes Implementadoras:**
1. `Livro` (implementa `IMaterial`):
   - Propriedades: `Titulo`, `Autor`, `ISBN`, `AnoPublicacao`, `Disponivel`
   - Implementar todos os métodos da interface

2. `Revista` (implementa `IMaterial`):
   - Propriedades: `Titulo`, `Autor`, `Numero`, `MesPublicacao`, `Disponivel`
   - Implementar todos os métodos da interface

3. `DVD` (implementa `IMaterial`):
   - Propriedades: `Titulo`, `Diretor`, `DuracaoMinutos`, `Disponivel`
   - Implementar todos os métodos da interface

**Classe `Biblioteca`:**
- Propriedade: `Materiais` (List<IMaterial>)
- Métodos:
  - `AdicionarMaterial(IMaterial material)`
  - `ListarMateriaisDisponiveis()`
  - `EmprestarMaterial(string titulo)`
  - `DevolverMaterial(string titulo)`
  - `GerarRelatorio()`

O programa deve:
- Gerenciar múltiplos tipos de materiais
- Controlar disponibilidade
- Exibir relatório de materiais disponíveis
- Validar empréstimos e devoluções

**Exemplo de saída:**
```
=== MATERIAIS DISPONÍVEIS ===
1. Clean Code (Autor: Robert Martin) - Livro - ISBN: 978-0132350884
2. National Geographic 145 (Autor: Editorial) - Revista - Edição Março/2024
3. Matrix (Diretor: Wachowski) - DVD - Duração: 136 minutos

=== EMPRÉSTIMOS REALIZADOS ===
✓ Clean Code emprestado com sucesso
✓ National Geographic 145 emprestado com sucesso
```


---

## Exercício 4: Análise de Vendas com Coleções e LINQ

**Objetivo:** Praticar coleções, LINQ e manipulação de dados complexos.
**Descrição:** Crie um sistema de análise de vendas usando coleções e LINQ:

**Classes:**
1. `Produto`:
   - Propriedades: `Id`, `Nome`, `Categoria`, `Preco`, `Estoque`

2. `Venda`:
   - Propriedades: `Id`, `Data`, `Produto`, `Quantidade`, `ValorUnitario`
   - Método: `CalcularTotal()` retorna `Quantidade * ValorUnitario`

3. `AnalisadorVendas`:
   - Propriedade: `Vendas` (List<Venda>)
   - Métodos usando LINQ:
     - `VendasPorMes(int mes, int ano)`: retorna vendas de um mês específico
     - `ProdutoMaisVendido()`: retorna o produto com maior quantidade vendida
     - `ReceitaTotal()`: retorna a soma de todas as vendas
     - `VendasPorCategoria()`: retorna vendas agrupadas por categoria
     - `ProdutosAcimaDaMedia()`: retorna produtos com preço acima da média
     - `Top5VendasAoVivo()`: retorna os 5 produtos mais vendidos
     - `TotalPorCategoria()`: retorna a receita total por categoria

O programa deve:
- Adicionar múltiplas vendas
- Utilizar LINQ para consultas complexas
- Exibir resultados formatados
- Gerar relatórios analíticos

**Exemplo de saída:**
```
=== ANÁLISE DE VENDAS ===
Receita Total: R$ 15.450,00

=== PRODUTOS MAIS VENDIDOS ===
1. Notebook - 45 unidades vendidas - R$ 2.025,00
2. Mouse - 120 unidades vendidas - R$ 360,00
3. Teclado - 85 unidades vendidas - R$ 425,00

=== RECEITA POR CATEGORIA ===
Eletrônicos: R$ 10.200,00
Periféricos: R$ 5.250,00

=== VENDAS DE MARÇO/2024 ===
Data: 05/03/2024 | Produto: Notebook | Quantidade: 5 | Total: R$ 2.500,00
Data: 12/03/2024 | Produto: Mouse | Quantidade: 20 | Total: R$ 200,00
Total do mês: R$ 2.700,00
```

## Exercício 5: Sistema de Redes Sociais com Validação e Regex

**Objetivo:** Integrar todos os conceitos: OOP, Coleções, LINQ, Strings e Regex.
**Descrição:** Crie um sistema simplificado de rede social com usuários, posts e comentários:

**Classes:**
1. `Usuario`:
   - Propriedades: `Id`, `NomeUsuario`, `Email`, `DataCriacao`, `Seguidores` (List<Usuario>)
   - Métodos:
     - `ValidarEmail()`: usar Regex para validar email
     - `AguirSeguidor(Usuario usuario)`
     - `DejarSeguidor(Usuario usuario)`
     - `ObterTotalSeguidores()`

2. `Post`:
   - Propriedades: `Id`, `Autor`, `Conteudo`, `DataCriacao`, `Curtidas` (int), `Comentarios` (List<Comentario>)
   - Métodos:
     - `Curtir()`
     - `AgregarComentario(Comentario comentario)`
     - `ObterEtiquetas()`: usar Regex para extrair #hashtags do conteúdo
     - `TiempoDecorrido()`: retorna quanto tempo passou desde a criação

3. `Comentario`:
   - Propriedades: `Id`, `Autor`, `Conteudo`, `DataCriacao`, `Curtidas` (int)
   - Métodos:
     - `Curtir()`
     - `ObterEtiquetas()`: usar Regex para extrair #hashtags

4. `RedeSocial`:
   - Propriedade: `Usuarios` (List<Usuario>), `Posts` (List<Post>)
   - Métodos usando LINQ:
     - `BuscarUsuario(string nomeUsuario)`
     - `BuscarPostsPorEtiqueta(string etiqueta)`
     - `ObterTendenciasDoDia()`: retorna as hashtags mais usadas do dia
     - `RecomendasionsDeSeguidores()`: retorna usuários que o usuário podría seguir
     - `PromoconarPost(Post post)`: ordena posts por engagement (curtidas + comentários)
     - `ValidarConteudo(string conteudo)`: usar Regex para validar se contém conteúdo apropriado

O programa deve:
- Criar usuários e validá-los
- Criar posts com hashtags
- Adicionar comentários
- Realizar buscas e análises com LINQ
- Exibir dados formatados e validados

**Exemplo de saída:**
```
=== FEED DE REDE SOCIAL ===

[Post de @joao • 2 horas atrás]
Adorei o novo produto! #tecnologia #inovação
❤️ 45 curtidas | 💬 8 comentários

  └─ @maria: Concordo totalmente! #tecnologia
     ❤️ 5 curtidas

  └─ @pedro: Qual marca? #tecnologia
     ❤️ 2 curtidas

=== TENDÊNCIAS DO DIA ===
#tecnologia - 1.250 menções
#inovação - 856 menções
#startup - 432 menções

=== RECOMENDAÇÕES DE SEGUIR ===
1. @carlos (Seguido por @joao e 5 outros)
2. @ana (Seguido por @maria e 3 outros)
3. @lucas (Seguido por 7 pessoas que você segue)
```

## 🎯 Critérios de Avaliação

Ao revisar suas soluções, considere:

1. **Funcionalidade:** O programa faz tudo o que foi solicitado?
2. **Orientação a Objetos:** As classes estão bem estruturadas com encapsulamento correto?
3. **Validações:** O programa trata entradas inválidas e edge cases?
4. **LINQ:** As consultas são eficientes e legíveis?
5. **Boas práticas:** O código segue padrões C# e é legível?
6. **Testes:** Existem testes unitários apropriados?
7. **Documentação:** O código está bem comentado e documentado?

## 📚 Recursos Adicionais

Consulte a documentação oficial:
- [Microsoft Learn - C# OOP](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/object-oriented/)
- [LINQ no C#](https://learn.microsoft.com/pt-br/dotnet/csharp/linq/)
- [Regex em C#](https://learn.microsoft.com/pt-br/dotnet/standard/base-types/regular-expressions)
- [Documentação oficial do C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- Material dos cursos da Alura

## 🚀 Dicas Importantes

- **Exercício 1:** Foque em criar uma classe bem encapsulada com validações
- **Exercício 2:** Use `virtual` e `override` com cuidado, pense na hierarquia de classes
- **Exercício 3:** Interfaces são contratos - todas as implementações devem seguir o mesmo padrão
- **Exercício 4:** LINQ é poderosa mas legibilidade é importante - use bem o indentação
- **Exercício 5:** Este é um projeto grande - divida em partes menores e teste cada uma

---

**Boa sorte e bons estudos! 🚀**
