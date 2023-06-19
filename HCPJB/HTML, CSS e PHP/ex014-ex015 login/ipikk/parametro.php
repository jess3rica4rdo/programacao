<?php

include_once('conexao.php');
$nome = $_POST['nome'];
$sobrenome = $_POST['sobrenome'];
$email = $_POST['email'];
$endereco = $_POST['endereco'];
$quantidade = $_POST['quantidade'];
$categoria = $_POST['categoria'];
$nome_editora = $_POST['nome_editora'];
$data_publicação = $_POST['data_publicação'];

$jesse = "INSERT INTO encomenda (nome,sobrenome,email,endereco,quantidade,categoria,nome_editora,data_publicação) VALUES ('$nome','$sobrenome','$email','$endereco','$quantidade','$categoria','$nome_editora','$data_publicação')";

if (Empty ($nome) or Empty ($sobrenome) or Empty ($email) or Empty ($endereco) or Empty ($quantidade) or Empty($categoria) or Empty($nome_editora) or Empty($data_publicação)){

    echo "<p style = 'color: red'> Erro! Campo vazio <br>";
}
else{

    $jesse = "INSERT INTO encomenda (nome,sobrenome,email,endereco,quantidade,categoria,nome_editora,data_publicação) VALUES ('$nome','$sobrenome','$email','$endereco','$quantidade','$categoria','$nome_editora','$data_publicação')";

    echo "<p style = 'color: blue'> Usuário cadastrado com sucesso!";
}

$jesse = mysqli_query ($Conn,$jesse)


?>

