<!DOCTYPE html>
<html lang="pt-br">
<head>
    <script src="https://kit.fontawesome.com/e2ad081ec5.js" crossorigin="anonymous"></script>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Como surgiu o macote do Android?</title>
    <link rel="shortcut icon" href="imagens/favicon.ico" type="image/x-icon">
    <link rel="stylesheet" href="estilo/stylecad.css">
</head>
<body>
    <header>
        <h1>Curiosidades de Tecnologia</h1>
        <p>Tudo aquilo que você sempre quis saber sobre o mundo Tech, em um único lugar</p>
    </header>
    <nav>
        <a href="index.php">Home</a>
        <a href="cad.php" class="pp">Pedidos</a>
        <a href="materias.php">Matérias</a>
        <a href="#">Fale Conosco</a>
    </nav>
    <main>
        <article>
            
            <div id="form">

                <form method="post" action="conexao.php">
                    
                    <h1 class="title">PEDIDO DE MATÉRIA</h1>
            
                    <label for="nome">Nome completo</label> 

                    <div class="input">
                        <i class="fa fa-user-circle-o" aria-hidden="true"></i>
                        <input id="nome" name="nome" placeholder="Nome" type="text" required>
                    </div>

                    <label for="email">Email</label>
                    <div class="input">
                        <i class="far fa-envelope" aria-hidden="true"></i>
                        <input id="email" name="email" placeholder="Mencione o seu email" type="text" required>
                    </div>
                    <label for="pais">País</label>
                    <div class="input">
                        <i class="fa-solid fa-location-dot" aria-hidden="true"></i>
                        <input id="pais" name="pais" placeholder="Mencione de onde fala connosco" type="text" required>
                    </div>

                    <label for="materia">Matéria que deseja</label>
                    <div class="input">
                        <i class="fa-solid fa-book-open"></i>
                        <input id="materia" name="materia" placeholder="Qual matéria deseja que postemos?" type="text" required>
                        
                    </div>
                    
                    <div id="cadastrar">
                        <button type="submit" class="btn" >Enviar</button>
                    
                        <button type="reset">Limpar</button>

                    </div>
                </form>
                
                
                
            </div>

            <picture>
                <source media="(max-width: 600px)" srcset="imagens/dan-droids-pq.png">
                <img src="imagens/dan-droids.png" alt="primeiro mascote de android">
            </picture>

        </article>
    </main>
    <footer>
        <p>Site criado por <a href="https://www.instagram.com/iam.jesse__/" target="_blank"  target="_blank" class="externo">Jessé Ricardo</a>, orientado pelo Professor <strong>Pedro Pembele</strong></p>
    </footer>
</body>
</html>