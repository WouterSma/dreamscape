
<!DOCTYPE html>
<html>
<head>
    <title>Registreren</title>
    <link rel="stylesheet" type="text/css" href="player/styles/styles.css">
</head>
<body>
    <div class="form-container">
        <h1>2. Registreren</h1>
        <form action="controllers/registerController.php" method="post">
            <input type="text" id="email" name="email" placeholder="Email"><br>
            <input type="text" id="gebruikersnaam" name="username" placeholder="Gebruikersnaam"><br>
            <input type="password" id="wachtwoord" name="password" placeholder="Wachtwoord"><br>
            <input type="password" id="herhaal-wachtwoord" name="repeat-password" placeholder="Herhaal Wachtwoord"><br>
            <input type="submit" value="Registreren -> 3">
        </form>
        <a href="login.php">Terug -> 1</a>
    </div>
</body>
</html>
