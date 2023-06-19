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

$jesse = mysqli_query ($Conn,$jesse)


?>

