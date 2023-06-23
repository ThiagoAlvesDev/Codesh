## Api para manipulação de dados de produtos
<hr>

Foi proposto um teste de construção de api junto a codesh, após muita pesquisar eu decide admitir que não tinha os conhecimentos necessários para aplicar todo o desenvolvimento do projeito. Mas queria fazer algo. Então decide aplicar meus conhecimentos e com base na interpretação da proposta, realizei este projeto. O documento original fornecido pode ser acessado [aqui](/Documentation/products-parser-20230105/README.md)

A api possui um contexto simples desenvolvido em cima do swagger com c#. Nela poderá inserir dados de um respectivo produto onde para criação dos campos utilizei o arquivo [Products](Documentation/products-parser-20230105/products.json)

Foi utilizado um banco de dados não realacional em nuvem. 
MongoDB Atlas Database.

Para rodar o projeto é preciso configurar o seu banco de dados. Eu configurei dentro de [appsettings.Development](ProjetoCodesh/appsettings.Development.json). Mas fica a seu critério.

Após configuração o projeto estará pronto para rodar. Em um terminal de sua preferência utilize o comando ou use uma IDE de sua preferência

        dotnet watch run


<em> Pude aprender muito, definir meus limites e so tenho a agradecer, sempre tento ser 1% a mais que ontem e continuarei em frente.</em>
