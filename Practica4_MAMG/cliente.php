<?php
    require_once "lib/nusoap.php";
    $cliente = new nusoap_client("http://localhost/Practica4_MAMG/server.php");

    $error = $cliente->GetError();
    if ($error){
        echo "<h2>Fatal Error</h2><pre>" .$error ."</pre>";
    }
    $result = $cliente->call("GetAnime",array("datos" => "Titulos"));
    if ($cliente->fault) {
        echo "<h2>Fault</h2><pre>";
        print_r($result);
        echo "</pre>";
    }
    else {
        $error = $cliente->GetError();
        if ($error){
            echo "<h2>Error</h2><pre>" .$error ."</pre>";
        }
        else {
            echo "<h2>Titulos</h2><pre>";
            echo $result;
            echo "</pre>";
        }
    }
?>