﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="src_html_login" %>

<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>login</title>
    <link rel="shortcut icon" type="image/png" href="../assets/images/logos/Untitled-3.png" />
    <link rel="stylesheet" href="../assets/css/styles.min.css" />
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function exampleInputPassword1_onclick() {

        }

// ]]>
    </script>
</head>
<body>
    <!--  Body Wrapper -->
    <div class="page-wrapper" id="main-wrapper" data-layout="vertical" data-navbarbg="skin6"
        data-sidebartype="full" data-sidebar-position="fixed" data-header-position="fixed">
        <div class="position-relative overflow-hidden text-bg-light min-vh-100 d-flex align-items-center justify-content-center">
            <div class="d-flex align-items-center justify-content-center w-100">
                <div class="row justify-content-center w-100">
                    <div class="col-md-8 col-lg-6 col-xxl-3">
                        <div class="card mb-0">
                            <div class="card-body">
                                <a href="./index.html" class="text-nowrap logo-img text-center d-block py-3 w-100">
                                    &nbsp;<img src="../assets/images/logos/Untitled-3.png" alt=""></a><p class="text-center">
                                    Enter Your Data for login</p>
                                <form id="Form1" runat="server">
                                <p class="text-start">
                                    <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
                                </p>
                                
                                <asp:RadioButtonList ID="rbllog" runat="server" Height="29px" 
                                    RepeatDirection="Horizontal" Width="266px" 
                                    onselectedindexchanged="rbllog_SelectedIndexChanged">
                                    <asp:ListItem Value="1">Employee</asp:ListItem>
                                    <asp:ListItem Value="2">Student</asp:ListItem>
                                </asp:RadioButtonList>
                               <br />
                                <label for="exampleInputPassword1" class="form-label">Email</label>
                                
                                <asp:TextBox ID="txtemail"  class="form-control" placeholder="Enter your Email" runat="server"></asp:TextBox>
                                <%--   <div class="mb-3">
                                    <label for="exampleInputEmail1" class="form-label">
                                        Enter Email</label>
                                    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
                                </div>--%>
                                <div class="mb-4">
                                    <label for="exampleInputPassword1" class="form-label">Password</label>
                                    <asp:TextBox ID="txtpassword"  class="form-control"  
                                        placeholder="Enter your Password" runat="server" TextMode="Password"></asp:TextBox>
                                    <%--<input type="password" class="form-control" id="exampleInputPassword1" onclick="return exampleInputPassword1_onclick()">--%>
                                </div>
                                <div class="d-flex align-items-center justify-content-between mb-4">
                                    <div class="form-check">
                                        <input class="form-check-input primary" type="checkbox" value="" id="flexCheckChecked"
                                            checked>
                                        <label class="form-check-label text-dark" for="flexCheckChecked">
                                            Remeber this Device
                                        </label>

                                <asp:Button ID="btnlogin" 
                                    class="btn btn-primary w-100 py-8 fs-4 mb-4 rounded-2" runat="server" 
                                    Text="Login" onclick="btnlogin_Click" />
                                        <%--                          <a href="./index.aspx" class="btn btn-primary w-100 py-8 fs-4 mb-4 rounded-2">Login</a>--%>
                                <div class="d-flex align-items-center justify-content-center">
                                    <%--                    <p class="fs-4 mb-0 fw-bold">New to MaterialM?</p>--%><%--                    <a class="text-primary fw-bold ms-2" href="./authentication-register.html">Create an account</a>--%>
                                </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="../assets/libs/jquery/dist/jquery.min.js"></script>
    <script src="../assets/libs/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    <!-- solar icons -->
    <script src="https://cdn.jsdelivr.net/npm/iconify-icon@1.0.8/dist/iconify-icon.min.js"></script>
</body>
</html>



