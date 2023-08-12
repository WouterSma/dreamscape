<?php require 'header.php';?>
<!DOCTYPE html>
<html>
<head>
    <title>Loginscherm</title>
    <link rel="stylesheet" type="text/css" href="player/styles/styles.css">
</head>
<body>
    <div class="form-container">
        <h1>1. Loginscherm</h1>
        <form action="controllers/loginController.php" method="post">
            <input type="text" id="gebruikersnaam" name="username" placeholder="Gebruikersnaam"><br>
            <input type="password" id="wachtwoord" name="password" placeholder="Wachtwoord"><br>
            <input type="submit" value="Login">
        </form>
        <a href="register.php">Registreren -> 2</a>
    </div>
</body>
</html>
