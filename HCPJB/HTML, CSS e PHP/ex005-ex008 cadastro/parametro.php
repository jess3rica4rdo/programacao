<?php

include_once('conexao.php');
$nome = $_POST['name'];
$email = $_POST['email'];
$endereco = $_POST['endereco'];
$senha = $_POST['senha'];
$confirmar_senha = $_POST['confirmar_senha'];

$jesse = "INSERT INTO cadastro (nome,email,endereco,senha,confirmar_senha) VALUES ('$nome','$email','$endereco','$senha','$confirmar_senha')";

$jesse = mysqli_query ($conn,$jesse)


?>

