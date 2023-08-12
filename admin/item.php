<!DOCTYPE html>
<html>
<head>
    <title>Item Toevoegen</title>
    <link rel="stylesheet" type="text/css" href="styles/styles.css">
</head>
<body>
    <div class="form-container">
        <h1>14. Item Toevoegen/Bewerken</h1>
        <form action="items.php" method="post">
            <input type="text" name="naam" placeholder="Naam" required>
            <textarea name="beschrijving" placeholder="Beschrijving" required></textarea>
            <select name="type" required>
                <option value="" disabled selected>Type</option>
                <option value="wapen">Wapen</option>
                <option value="armor">Armor</option>
                <option value="accessoire">Accessoire</option>
            </select>
            <input type="number" name="zeldzaamheidsgraad" placeholder="Zeldzaamheidsgraad" required>
            <input type="number" name="kracht" placeholder="Kracht" required>
            <input type="number" name="snelheid" placeholder="Snelheid" required>
            <input type="number" name="duurzaamheid" placeholder="Duurzaamheid" required>
            <input type="number" name="magic" placeholder="Magic" required>
            <input type="submit" value="Item Opslaan">
        </form>
        <a href="dashboard.php" class="menu-button">Terug -> 11</a>
    </div>
</body>
</html>
