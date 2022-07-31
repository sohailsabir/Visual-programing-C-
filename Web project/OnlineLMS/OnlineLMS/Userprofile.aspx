<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Userprofile.aspx.cs" Inherits="OnlineLMS.Userprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
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
                                            <h3>USER PROFILE</h3>
                                        <span>Account Status-</span>
                                            <asp:Label ID="Label1" runat="server" Text="Your status"></asp:Label>
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
                                <div class="col-md-4">
                                     <label >USER NAME</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox5" placeholder="USER NAME" runat="server" ReadOnly="True"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <label  >OLD PASSWORD</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox6" TextMode="Password" placeholder="PASSWORD" runat="server" ReadOnly="True"></asp:TextBox>

                                    </div>
                                </div>
                                      <div class="col-md-4">
                                    <label  >NEW PASSWORD</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox7" TextMode="Password" placeholder="PASSWORD" runat="server" ></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                             <div class="row">
                                <div class="col">
                                     
                                     
                                    <br />
                                  
                                    <div class="form-group">
                                        <div class="d-grid gap-2">
                                        <asp:Button  class="btn btn-primary " ID="Button1" runat="server" Text="UPDATE"   />
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
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                          <img width="100px" src="imgs/issueBook.gif" />
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h3>YOUR ISSUED BOOKS</h3>
                                        
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <hr />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                                </div>
                            </div>
                           
                           
                        
                    
                        </div>
                     
                        </div>
                
             
                    </div>
                </div>
         </div>


</asp:Content>
