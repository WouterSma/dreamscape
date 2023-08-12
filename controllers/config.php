<?php
$servername = 'localhost';
$username = 'root';
$password = '';
$dbname = 'dreamscape';
$salt = '87d7f56b4bec43abc1fdd21b3be2eb44';
$pepper = 'ae6e95464b4850ca3b9e5b94c5a7c6aa';

try {
    $pdo = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch(PDOException $e) {
    echo "Connection failed: " . $e->getMessage();
    exit();
}
?>
