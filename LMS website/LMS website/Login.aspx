<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LMS_website.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login and Registration</title>
    <link href="loginstyle.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" runat="server"></form>
    <div class="main">
    <div class="form-box">
        <div class="button-box">
            <div id="btn"></div>
            <button type="button" class="toggle-btn" onclick="login()">Login</button>
            <button type="button" class="toggle-btn" onclick="register()">Register</button>
        </div>
         <form class="input-group" id="login">
             <input type="text"  name="" class="input-feild" placeholder="User Name"/>
             <input type="password"  name="" class="input-feild" placeholder="Enter Password"/>
             <input type="checkbox" class="check-box" /><span>Remember Password</span>
             <button type="submit" class="submit-btn">Login</button>
         </form>
         <form class="input-group" id="register">
             <input type="text"  name="" class="input-feild" placeholder="User Name"/>
              <input type="email"  name="" class="input-feild" placeholder="Email Id"/>
             <input type="password"  name="" class="input-feild" placeholder="Enter Password"/>
             <input type="checkbox" class="check-box" /><span>I agree to the terms & conditions</span>
             <button type="submit" class="submit-btn">Register</button>
         </form>

    </div>
    </div>
    <script>

        var x = document.getElementById("login");
        var y = document.getElementById("register");
        var z = document.getElementById("btn")
        function register() {
            x.style.left = "-400px";
            y.style.left = "50px";
            z.style.left = "110px";

        }
        function login () {
            x.style.left = "50px";
            y.style.left = "450px";
            z.style.left = "0";

        }

    </script>
 
</body>
</html>
