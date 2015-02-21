<html>
<head>
    <meta charset="UTF-8">
    <title>CV Generator</title>
</head>
<body>

    <div id="wrapper">
        <form method="post">
            <fieldset>
                <legend>Personal Infromation</legend>
                <input placeholder="First Name" type="text"/><br/>
                <input placeholder="Last Name" type="text"/><br/>
                <input placeholder="Email" type="email"/><br/>
                <input placeholder="Phone Number" type="tel"/><br/>

                <label for="female">Female</label>
                <input type="radio" name="gender" value="female" id="female"/>
                <label for="male">Male</label>
                <input type="radio" name="gender" value="male" id="male"/><br/>

                <label for="birth">Birth Date</label><br/>
                <input type="text" id="birth" name="birthDate" placeholder="dd/mm/yyyy"/><br/>

                <label for="nat">Nationality</label>
                <select name="nationality" id="nat">
                    <option value="bg">Bulgarian</option>
                    <option value="it">Italian</option>
                    <option value="sp">Spanish</option>
                    <option value="gr">Greek</option>
                    <option value="us">American</option>
                </select>
            </fieldset>

            <fieldset>
                <legend>Last Work Position</legend>
                <label for="companyName">Company Name</label>
                <input type="text" id="companyName" name="compName"/><br/>

                <label for="lwpf">From</label>
                <input type="text" id="lwpf" name="lwpf"/><br/>

                <label for="lwpt">To</label>
                <input type="text" id="lwpt" name="lwpt"/><br/>
            </fieldset>

            <fieldset>
                <legend>Computer Skills</legend>
                <label>Programming Languages</label>

                <div id="skills1">
                    <input type="text" name="lang1"/>
                    <select name="rate">
                        <option value="beginner">Beginner</option>
                        <option value="programmer">Programmer</option>
                        <option value="ninja">Ninja</option>
                    </select>
                </div>
            </fieldset>

            <fieldset>
                <legend>Other Skills</legend>
                <label>Languages</label>

                <div id="lang1">
                    <input type="text" name=""/>
                </div>
            </fieldset>

            <input type="submit" value="Generate CV"/>
        </form>
    </div>

</body>
</html>