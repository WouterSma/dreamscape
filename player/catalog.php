<!DOCTYPE html>
<html>
<head>
    <title>Catalogus</title>
    <link rel="stylesheet" type="text/css" href="styles/styles.css">
</head>
<body>
    <div class="inventory-container">
        <h1>6. Catalogus</h1>
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
                <input type="submit" value="Zoeken">
            </form>
        </div>
        <div class="item-list">
            <h2>Alle items</h2>
            <ul>
                <!-- Voeg items toe aan deze lijst -->
                <li>Item 1</li>
                <li>Item 2</li>
            </ul>
        </div>
        <div class="item-details">
            <h2>Geselecteerd item details</h2>
            <p>Zeldzaamheid: zeldzaam</p>
            <p>Kracht: 100</p>
            <p>Snelheid: 50</p>
            <p>Duurzaamheid: 80</p>
            <p>Magische eigenschappen: vuur</p>
            <!-- Hier een placeholder voor de afbeelding -->
            <img src="#" alt="Placeholder Image">
        </div>
        <a href="dashboard.php" class="menu-button">Terug -> 3</a>
    </div>
</body>
</html>
