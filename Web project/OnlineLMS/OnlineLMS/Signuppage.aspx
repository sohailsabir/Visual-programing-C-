<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Signuppage.aspx.cs" Inherits="OnlineLMS.Signuppage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                           <img width="100px" src="imgs/icons8-student-male-50.png" />
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h3>USER Registratioin</h3>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <hr />
                                </div>
                            </div>
                           
                            <div class="row">
                                <div class="col-md-6">
                                     <label >FULL NAME</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox3" placeholder="FULL NAME" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label  >DATE OF BIRTH</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox2" TextMode="Date"  runat="server"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                     <label >REGISTRATION NO</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" placeholder="REGISTRATION NO"  runat="server"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label  >EMAIL ID</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox4" TextMode="Email" placeholder="EMAIL ID" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                                 <div class="row">
                                <div class="col-md-6">
                                     <label >USER NAME</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox5" placeholder="USER NAME" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label  >PASSWORD</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox6" TextMode="Password" placeholder="PASSWORD" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                             <div class="row">
                                <div class="col">
                                     
                                     
                                    <br />
                                  
                                    <div class="form-group">
                                        <div class="d-grid gap-2">
                                        <asp:Button  class="btn btn-success " ID="Button1" runat="server" Text="SIGN UP"   />
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
