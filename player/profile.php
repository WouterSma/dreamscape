<!DOCTYPE html>
<html>
<head>
    <title>Profiel</title>
    <link rel="stylesheet" type="text/css" href="styles/styles.css">
</head>
<body>
    <div class="form-container">
        <h1>7. Profiel</h1>
        <div class="profile-info">
            <h2>Naam: <span id="username">Gebruikersnaam</span></h2>
            <input type="button" value="Bewerken" onclick="editUsername()">
        </div>
        <div class="profile-info">
            <h2>Email: <span id="email">email@example.com</span></h2>
            <input type="button" value="Bewerken" onclick="editEmail()">
        </div>
        <div class="profile-info">
            <h2>Wachtwoord: ******</h2>
            <input type="button" value="Bewerken" onclick="editPassword()">
        </div>
        <a href="messages.php" class="menu-button">Notificaties -> 8</a>
        <a href="dashboard.php" class="menu-button">Terug -> 3</a>
    </div>
    <script>
        function editUsername() {
            // voeg hier de logica toe om de gebruikersnaam te bewerken
        }

        function editEmail() {
            // voeg hier de logica toe om de email te bewerken
        }

        function editPassword() {
            // voeg hier de logica toe om het wachtwoord te bewerken
        }
    </script>
</body>
</html>
