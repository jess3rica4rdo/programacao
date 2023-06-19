<?php

include_once('conexao.php');
$nome = $_POST['nome'];
$email = $_POST['email'];
$endereco = $_POST['pais'];
$quantidade = $_POST['materia'];

$jesse = "INSERT INTO pedido (nome,email,pais,materia) VALUES ('$nome','$email','$pais','$materia')

$jesse = mysqli_query ($Conn,$jesse)

?>

