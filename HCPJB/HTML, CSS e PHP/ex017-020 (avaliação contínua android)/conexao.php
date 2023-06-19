<?php

$servidor = "localhost";
$usuario = "root";
$senha = "";
$dbname = "android";
$Conn = mysqli_connect($servidor, $usuario, $senha, $dbname);

$nome = $_POST['nome'];
$email = $_POST['email'];
$pais = $_POST['pais'];
$materia = $_POST['materia'];

$jesse = "INSERT INTO pedido (nome,email,pais,materia) VALUES ('$nome','$email','$pais','$materia')";

$jesse = mysqli_query ($Conn,$jesse);

header("Location: cad.php");

?>


