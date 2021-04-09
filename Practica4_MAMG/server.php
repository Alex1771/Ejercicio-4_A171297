<?php
    require_once "lib/nusoap.php";
    function GetAnime ($datos){
        if ($datos == "Titulos"){
            return Join(",", array (
                "Slime",
                "Shingueky no kyojin",
                "Btomm",
                "One piece"
            ));
        }
        else {
            return "No hay titulos";
        }
    }
    $server = new soap_server();
    $server->register("GetAnime");
    if (!isset($HTTP_RAW_POST_DATA)) $HTTP_RAW_POST_DATA = file_get_contents('php://input');
    $server->service($HTTP_RAW_POST_DATA);
?>