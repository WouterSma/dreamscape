<!DOCTYPE html>
<html>
<head>
    <title>Gebruiker Toevoegen</title>
    <link rel="stylesheet" type="text/css" href="styles/styles.css">
</head>
<body>
    <div class="form-container">
        <h1>13. Gebruiker Toevoegen/Bewerken</h1>
        <form action="#" method="post">
            <input type="text" name="gebruikersnaam" placeholder="Gebruikersnaam" required>
            <input type="email" name="email" placeholder="Email" required>
            <input type="password" name="wachtwoord" placeholder="Wachtwoord" required>
            <input type="password" name="herhaal-wachtwoord" placeholder="Herhaal Wachtwoord" required>
            <label for="type">Type</label>
            <select name="type">
                <option>Speler</option>
                <option>Beheerder</option>
            </select>
            <input type="submit" value="Opslaan">
        </form>
        <a href="users.php" class="menu-button">Terug -> 10</a>
    </div>
</body>
</html>
