<!DOCTYPE html>
<html lang="pt-pt">
<head>
    <script src="https://kit.fontawesome.com/e2ad081ec5.js" crossorigin="anonymous"></script>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="stylecadfun.css">
    <title>hutombelu</title>
</head>

<body>
    <div id="site">
        <div id="cabeca">
            <div class="cima">
                <div class="ex">
                    <img src="imagens/fotos/Logo_Ipikk.png" alt="logo da escola" width="160px">
                </div>

            </div>
    
            <div class="menu">
                <nav>
                    <a href="index.php">Início</a>
                    <a href="#">Encomendas</a>
                    <a href="#">Livros Publicados</a>
                    <a href="#">Contactos</a>

                </nav>
            </div>
            <div id="titulo">
                
            </div>
        </div>

 
        <div id="jj">
            <div id="form">

                <form method="post" action="parametro.php">
                    <h1 class="title">DADOS DO USUÁRIO</h1>
            
                    <label for="nome">Nome Próprio</label> 

                    <div class="input">
                        <i class="fa fa-user-circle-o" aria-hidden="true"></i>
                        <input id="nome" name="nome" placeholder="Nome" type="text">
                    </div>

                    <label for="sobrenome">Sobrenome</label>
                    <div class="input">
                        <i class="fa fa-user-circle-o" aria-hidden="true"></i>
                        <input id="sobrenome" name="sobrenome" placeholder="Sobrenome" type="text">
                    </div>

                    <label for="email">Email</label>
                    <div class="input">
                        <i class="far fa-envelope" aria-hidden="true"></i>
                        <input id="email" name="email" placeholder="Email" type="text">
                    </div>
                    <label for="endereco">Endereço</label>
                    <div class="input">
                        <i class="fa-solid fa-location-dot" aria-hidden="true"></i>
                        <input id="endereco" name="endereco" placeholder="Mencione o endereço" type="text">
                    </div>

                    <label for="quantidade">Quantidade</label>
                    <div class="input">
                        <i class="fa-solid fa-location-dot" aria-hidden="true"></i>
                        <input id="quantidade" name="quantidade" placeholder="Mencione muantidade" type="text">
                    </div>

                    <label for="categoria">Categoria</label>
                    <div class="input">
                        <i class="fa-solid fa-location-dot" aria-hidden="true"></i>
                        <input id="categoria" name="categoria" placeholder="Mencione a categoria do livro" type="text">
                    </div>

                    <label for="nome_editora">Nome da Editora</label>
                    <div class="input">
                        <i class="fa fa-user-circle-o" aria-hidden="true"></i>
                        <input id="nome_editora" name="nome_editora" placeholder="Mencione o nome da editora" type="text">
                    </div>

                    <label for="data_publicação">data de publicação</label>
                    <div class="input">
                        <i class="fa fa-user-circle-o" aria-hidden="true"></i>
                        <input id="data_publicação" name="data_publicação" placeholder="Data de publicação" type="date">
                    </div>
                    
                    <div id="cadastrar">
                        <button type="submit">Cadastrar</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>