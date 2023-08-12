<!DOCTYPE html>
<html>
<head>
    <title>Handelsysteem</title>
    <link rel="stylesheet" type="text/css" href="styles/styles.css">
</head>
<body>
    <div class="tradingsystem-container">
        <h1>5. Handelsysteem</h1>
        <div class="search-filter-container">
            <form action="#" method="post">
                <input type="text" id="zoekveld" name="zoekveld" placeholder="Zoekveld">
                <div class="filter-options">
                    <input type="checkbox" id="filter1" name="filter1">
                    <label for="filter1">Filter 1</label>
                    <input type="checkbox" id="filter2" name="filter2">
                    <label for="filter2">Filter 2</label>
                    <!-- Voeg meer checkboxes toe indien nodig -->
                </div>
                <input type="submit" value="Filteren">
            </form>
        </div>
        <div class="trade-items">
            <h2>Items te koop</h2>
            <ul>
                <!-- Voeg items toe aan deze lijst -->
                <li>Item 1 - Status: Te koop - Biedingen: 5</li>
                <li>Item 2 - Status: Te koop - Biedingen: 2</li>
            </ul>
        </div>
        <div class="my-items">
            <h2>Mijn aangeboden items</h2>
            <ul>
                <!-- Voeg items toe aan deze lijst -->
                <li>Item A - Status: Te koop - Biedingen: 3</li>
                <li>Item B - Status: Te koop - Biedingen: 0</li>
            </ul>
        </div>
        <div class="bidded-items">
            <h2>Items waar ik op geboden heb</h2>
            <ul>
                <!-- Voeg items toe aan deze lijst -->
                <li>Item X - Status: In afwachting - Mijn bod: 100</li>
                <li>Item Y - Status: In afwachting - Mijn bod: 50</li>
            </ul>
        </div>
        <a href="dashboard.php" class="menu-button">Terug -> 3</a>
    </div>
</body>
</html>
