<?php
require 'config.php';

$username = strval($_POST['username']);
$password = strval($_POST['password']);

// prepared statement to select the user with the provided username
$sql = "SELECT * FROM `users` WHERE `username` = :username LIMIT 1 ";
$stmt = $pdo->prepare($sql);

// execute the prepared statement, passing in the username value
$stmt->execute(['username' => $username]);

// fetch the user
$user = $stmt->fetch(PDO::FETCH_ASSOC);

if ($user === false) {
    die('No user found with that username!');
} else {
    // handle the case where a user was found
    // for example, verify the provided password against the hashed password in the database
    if (password_verify($salt.$password.$pepper, $user['password'])) {
        // the provided password is correct
        // log in the user and redirect to the dashboard
        session_start();
        $_SESSION['user_id'] = $user['id'];  // save the user's id in the session
        header('location: ../player/dashboard.php');
        exit;
    } else {
        // the provided password is incorrect
        // handle incorrect password
        die('Incorrect password!');
    }
}
?>
