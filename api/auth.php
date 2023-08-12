<?php
require '../vendor/autoload.php';
use \Firebase\JWT\JWT;

$key = hash("sha256","32887103c5dcfcc921140bcfa6addfbfc9d393a4a03ccb1b2e73ca8621e6b51a376a12b2e845012c52d2e33695190b3016d6cf5867dd146f961b71e81ce96816");

function generateToken($userId, $userName, $key) {
    $payload = array(
        "iss" => "localhost/dreamscape",  // Replace with your domain
        "aud" => "localhost/dreamscape",  // Replace with your domain
        "iat" => 1356999524,
        "nbf" => 1357000000,
        "userId" => $userId,
        "userName" => $userName
    );

    $jwt = JWT::encode($payload, $key, 'HS256');  // The 'HS256' algorithm is added here
    return $jwt;
}

function validateToken($jwt, $key) {
    try {
        $decoded = JWT::decode($jwt, $key, null);
        return (array) $decoded;  // The decoded object is converted to an array here
    } catch (Exception $e) {
        return null;
    }
}
