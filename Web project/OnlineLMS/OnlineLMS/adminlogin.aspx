<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="OnlineLMS.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <img width="150px" src="imgs/password-removebg-preview.png" />
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h3>Admin LOGIN</h3>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>
                             <div class="row">
                                <div class="col">
                                     <label >User Name</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" placeholder="User Name" runat="server"></asp:TextBox>

                                    </div>
                                     <label  >Password</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox2" TextMode="Password" placeholder="Password" runat="server"></asp:TextBox>

                                    </div>
                                    <br />
                                  
                                    <div class="form-group">
                                        <div class="d-grid gap-2">
                                        <asp:Button  class="btn btn-success " ID="Button1" runat="server" Text="Login"   />
                                            </div>
                                    </div>
                                   
                                    
                                </div>
                           
                        </div>
                        
                        </div>
                    
                        </div>
                     
                        </div>
                
               <a href="homepage.aspx">Back to Home Page</a>
                    </div>
                </div>
         </div>
</asp:Content>
