# Nomes de Autores de Obras Bibliográficas

<p>Quando se lista o nome de autores de livros, artigos e outras publicações é comum que se apresente o nome do autor ou dos autores da seguinte forma: sobrenome do autor em letras maiúsculas, seguido de uma vírgula e da primeira parte do nome apenas com as iniciais maiúsculas.</p>

Por exemplo:<br />
1. SILVA, Joao <br />
2. COELHO, Paulo <br />
3. ARAUJO, Celso de <br />

<p>Seu desafio é fazer um programa que leia um número inteiro correspondendo ao número de nomes que será fornecido, e, a seguir, leia estes nomes (que podem estar em qualquer tipo de letra) e imprima a versão formatada no estilo exemplificado acima.</p>

As seguintes regras devem ser seguidas nesta formatação: </br>

1. O sobrenome será igual a última parte do nome e deve ser apresentado em letras maiúsculas;
2. Se houver apenas uma parte no nome, ela deve ser apresentada em letras maiúsculas (sem vírgula): se a entrada for “ Guimaraes” , a saída deve ser “ GUIMARAES”;
3. Se a última parte do nome for igual a "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA" ou "JUNIOR" e houver duas ou mais partes antes, a penúltima parte fará parte do sobrenome. Assim: se a entrada for "Joao Silva Neto", a saída deve ser "SILVA NETO, Joao" ; se a entrada for "Joao Neto" , a saída deve ser "NETO, Joao";
4. As partes do nome que não fazem parte do sobrenome devem ser impressas com a inicial maiúscula e com as demais letras minúsculas;
5. "da", "de", "do", "das", "dos" não fazem parte do sobrenome e não iniciam por letra maiúscula.
