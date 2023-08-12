<!DOCTYPE html>
<html>
<head>
    <title>Inventaris</title>
    <link rel="stylesheet" type="text/css" href="styles/styles.css">
</head>
<body>
    <div class="inventory-container">
        <h1>4. Inventaris</h1>
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
        <ul class="item-list">
            <!-- Voeg items toe aan deze lijst -->
            <li>Item 1</li>
            <li>Item 2</li>
        </ul>
        <div class="item-details">
            <h2>Geselecteerd item details</h2>
            <ul>
                <li>Zeldzaamheid: </li>
                <li>Kracht: </li>
                <li>Snelheid: </li>
                <li>Duurzaamheid: </li>
                <li>Magische eigenschappen: </li>
            </ul>
            <img src="placeholder.jpg" alt="Item afbeelding" style="width:200px;height:200px;border:1px solid black">
        </div>
        <a href="dashboard.php" class="menu-button">Terug -> 3</a>
    </div>
</body>
</html>
