# Estrutura de Dados (D&D Records)

<p align="center"><img src="icons/logo.png" width="250px"></p>

Este repositório trata-se de um trabalho de **Estrutura de Dados(ESTC3)** do **Instituto Federal de Ciências e Tecnologia de São Paulo(IFSP) - Campus Piracicaba**. Este grupo composto pelos integrantes desenvolvedores Aldemir Humberto Soares Neto, Isabelle Caroline de Carvalho Costa, João Pedro Carpanezi dos Santos e Murilo Azevedo Jacon.
O projeto é constituido por um sistema de vetores de structs de tamanho fixo o qual, utilizando metodologias de busca binária e ordenações juntamente com Tabela Hash, compõe um sistema de uma gravadora. 

## Instalação
Para fazer a instalação, basta apenas clonar o repositório em seu ambiente local e executar a compilação dos arquivos.
```
git clone https://github.com/jpcarpanezi/data-structure-project-record-company.git
```

## Manual de Utilização
### Inserir Artista
<img src="icons/user-plus.png" width="50px">

Ao iniciar o programa, você verá uma tela com alguns artistas, albuns e músicas pré-cadastrados no sistema. Ao clicar no primeiro ícone, é possível adicionar um novo artista.

### Inserir Música
<img src="icons/music.png" width="50px">

Após inserir um novo artista, você pode adicionar uma música e associar a um artista já cadastrado no sistema.

### Inserir Álbum
<img src="icons/record-vinyl.png" width="50px">

Por fim, é possível inserir um álbum, o mesmo pode ser associado a artistas e consequentemente músicas serem adicionadas.

### Buscas
<img src="icons/search.png" width="50px">

Além dos sistemas de inserção, foi aplicado um sistema de busca, o qual você pode procurar por artistas, álbuns e canções cadastradas pelo seu código de inserção.

### Relatórios
<img src="icons/file.png" width="50px">

Há também uma opção de gerar relatórios de categorias específicas, são essas, os artistas aniversariantes do mês (pesquisar pelo número do respectivo mês Ex: 01 para janeiro), os álbuns à serem lançados no ano, e uma lista de e-mails dos empresários associados a artistas da gravadora.

## Buscas e Ordenações
Neste projeto foi aplicado para busca, o algoritmo de busca binária, uma estrutura de array de complexidade de melhor caso O(1), caso médio O(log n) e pior caso O(log n).

Para ordenação dos elementos inseridos nos vetores, foi-se utilizado como chave um identificador inteiro, ordenado por um Merge Sort, uma estrutura de dados de array e listas ligadas de melhor caso Θ(n log n) típico, Θ(n) variante natural, caso médio Θ(n log n) e pior caso Θ(n log n).

No vetor de relatório de e-mails dos empresários, foi utilizado uma tabela de dispersão ou tabela hash, a qual associa chaves de pesquisa a valores. Para evitar casos de colisão, foi utilizado o método de *Open Addressing* chamado *Quadratic Probing*.

## Licença
Este projeto é um trabalho de cunho acadêmico, voltado para conhecimento de estrutura de dados e sem fins lucrativos. Olhe o arquivo de <a href="https://github.com/jpcarpanezi/data-structure-project-record-company/blob/master/LICENSE">LICENSE</a> para direitos e limitações (MIT).
