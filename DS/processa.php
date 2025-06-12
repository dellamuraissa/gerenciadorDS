<?php
include "tarefas.php";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    
    if (isset($_POST["nome"], $_POST["data_hora"])) {
        $nome = $_POST["nome"];
        $descricao = $_POST["descricao"] ?? '';
        $dataHora = $_POST["data_hora"];

        adicionarTarefa($nome, $descricao, $dataHora);
    
    
    } elseif (isset($_POST["id"], $_POST["status"])) {
        atualizarStatus($_POST["id"], $_POST["status"]);

  
    } elseif (isset($_POST["id"], $_POST["deletar"])) {
        deletarTarefa($_POST["id"]);
    }
}

header("Location: index.php");
exit;

