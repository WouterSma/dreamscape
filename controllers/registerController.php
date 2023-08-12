<?php
require 'config.php';
session_start();
$username = strval($_POST['username']);
$password = strval($_POST['password']);
$repeatPassword = strval($_POST['repeat-password']);
$email = strval($_POST['email']);

if($password !== $repeatPassword){
    die('Passwords did not match!'); 
    exit;
} else if(empty($password) || empty($repeatPassword))
{
    die("Wachtwoord mag niet leeg zijn!");
    exit;
} else {
    $passwordHash = password_hash($salt.$password.$pepper, PASSWORD_DEFAULT);
}

$sql = "SELECT * FROM `users` WHERE `username` = :username OR `email` = :email";
$stmt = $pdo->prepare($sql);
$stmt->execute(['username' => $username, 'email' => $email]);
$result = $stmt->fetch(PDO::FETCH_ASSOC);

if($stmt->rowCount() != 0){
    die('ERROR: User exists!');
} else {
    $sql = "INSERT INTO `users` (`username`, `email`, `password`, `role`) VALUES (:username, :email, :passwordHash, 'user');";
    $stmt = $pdo->prepare($sql);
    $stmt->execute(['username' => $username, 'email' => $email, 'passwordHash' => $passwordHash]);
    header('location: ../player/dashboard.php');
}



?>