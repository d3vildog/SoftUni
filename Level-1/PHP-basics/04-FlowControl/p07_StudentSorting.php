<html>
<head>
    <meta charset="UTF-8">
    <title>Student Sorting</title>
    <style>
        * {
            box-sizing: border-box;
            outline: none;
        }

        tr {
            width: 500px;
        }

        table, td{
            text-align: left;
            border: 1px solid black;
            border-spacing: 10px;
        }

        a {
            text-decoration: none;
            font-size: 15px;
            color: white;
            font-weight: bold;
            display: inline-block;
            background-color: darkgray;
            width: 20px;
            text-align: center;
        }

        input[type="number"], input[type="text"] {
            border: none;
            padding-left: 10px;
            height: 20px;
        }

        td {
            width: 160px;
        }

        td:nth-of-type(4) {
            width: 85px;
        }

        td:nth-of-type(5) {
            width: 25px;
            border: none;
            text-align: center;
        }

        input[type='number']{
            width: 85px;
        }
    </style>
</head>
<body>

    <div id="wrapper">
        <div id="contend">
            <form method="post">
                <table>
                    <thead>
                        <tr>
                            <th>First name:</th>
                            <th>Second name:</th>
                            <th>Email:</th>
                            <th>Exam score:</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><input type="text" name="fn[]"/></td>
                            <td><input type="text" name="sn[]"/></td>
                            <td><input type="text" name="email[]"/></td>
                            <td><input type="number" name="es[]"/></td>
                            <td><a href="">-</a></td>
                        </tr>
                        <tr>
                            <td><input type="text" name="fn[]"/></td>
                            <td><input type="text" name="sn[]"/></td>
                            <td><input type="text" name="email[]"/></td>
                            <td><input type="number" name="es[]"/></td>
                            <td><a href="">-</a></td>
                        </tr>
                    </tbody>
                </table>

                <div id="submission">
                    <a href="">+</a>
                    <label for="sort">Sort by:</label>
                    <select name="sort" id="sort">
                        <option value="fn">First name</option>
                        <option value="ln">Last name</option>
                        <option value="email">Email</option>
                        <option value="es">Exam score</option>
                    </select>
                    <label for="order">Order:</label>
                    <select name="order" id="order">
                        <option value="asc">Ascending</option>
                        <option value="des">Descending</option>
                    </select>
                    <input type="submit" value="SUBMIT"/>
                </div>
            </form>
        </div>
    </div>

    <script>
        function addRow(){
            var newRow = document.createElement('tr');
            newRow.innerHTML =
           "<td><input type=\"text\" name=\"fn[]\"/></td>
            <td><input type=\"text\" name=\"sn[]\"/></td>
            <td><input type=\"text\" name=\"email[]\"/></td>
            <td><input type=\"number\" name=\"es[]\"/></td>
            <td><a href=\"\">-</a></td>";
        }
    </script>

</body>
</html>