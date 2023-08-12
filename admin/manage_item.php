<!DOCTYPE html>
<html>
<head>
    <title>Item toewijzen aan spelers</title>
    <link rel="stylesheet" type="text/css" href="styles/styles.css">
</head>
<body>
    <div class="form-container">
        <h1>15. Item toewijzen aan spelers</h1>
        <h2>Item in bezit van:</h2>
        <ul>
            <li>Speler 1 - Hoeveelheid: 2</li>
            <li>Speler 2 - Hoeveelheid: 1</li>
            <!-- meer spelers hier -->
        </ul>
        <p>Totaal aantal spelers met item: 2</p>
        <p>Totaal aantal items in omloop: 3</p>
        
        <form>
            <h2>Wijs item toe aan speler:</h2>
            <label for="player">Kies een speler:</label>
            <select id="player" name="player">
                <option value="speler1">Speler 1</option>
                <option value="speler2">Speler 2</option>
                <!-- meer spelers hier -->
            </select>
            <input type="submit" value="Item toewijzen">
        </form>
        
        <a href="items.php" class="menu-button">Terug -> 11</a>
    </div>
</body>
</html>
