<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="membermanagement.aspx.cs" Inherits="OnlineLMS.membermanagement" %>
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
                                            <h3>Member Detail</h3>
                                      
                                    </center>
                                </div>
                            </div>
                             <div class="row">
                                <div class="col">
                                    <center>
                                         <img width="100px" src="imgs/addstudent.gif" />
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <hr />
                                </div>
                            </div>
                           
                            <div class="row">
                                <div class="col-md-4">
                                     <label >Resgistration No</label>
                                    <div class="form-group">
                                        
                                          <div class="input-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox3" placeholder="Registration No" runat="server"></asp:TextBox>
                                                 <asp:Button  class="btn btn-primary " ID="Button1" runat="server" Text="GO"   />
                                           </div>
                                        
                                    </div>
                                        </div>
                                <div class="col-md-3">
                                    <label  >Full Name</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox5" placeholder="Full Name" runat="server" ReadOnly="True"></asp:TextBox>

                                    </div>
                                </div>
                                 <div class="col-md-5">
                                    <label  >Account Status</label>
                                    <div class="form-group">
                                        <div class="input-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox6" placeholder="Status" runat="server" ReadOnly="True"></asp:TextBox>
                                                
                                            <asp:LinkButton class="btn btn-primary " ID="LinkButton1" runat="server"><i class="fa fa-check-circle"></i></asp:LinkButton>
                                            <asp:LinkButton class="btn btn-warning " ID="LinkButton2" runat="server"><i class="fa fa-pause-circle"></i></asp:LinkButton>
                                            <asp:LinkButton class="btn btn-danger " ID="LinkButton3" runat="server"><i class="fa fa-times-circle"></i></asp:LinkButton>
                                           </div>

                                    </div>
                                </div>
                               
                        </div>
                            <div class="row">
                                <div class="col-md-6">
                                     <label >DOB</label>
                                    <div class="form-group">
                                        
                                          
                                                <asp:TextBox CssClass="form-control" ID="TextBox1" placeholder="DOB" runat="server" ReadOnly="True" TextMode="Date"></asp:TextBox>
                                        
                                           
                                        
                                    </div>
                                        </div>
                                <div class="col-md-6">
                                     <label >Email</label>
                                    <div class="form-group">
                                        
                                          
                                                <asp:TextBox CssClass="form-control" ID="TextBox2" placeholder="Email" runat="server" ReadOnly="True" TextMode="Email"></asp:TextBox>
                                        
                                           
                                        
                                    </div>
                                        </div>
                               
                               
                        </div>
                           
                            <br />
                            
                             <div class="row">
                                <div class="col-12">
                                    <div class="d-grid gap-2">
                                    <asp:Button class="btn btn-lg btn-danger" ID="Button2"  runat="server" Text="Delete Account" />
                                        </div>
                                </div>
                               
                                
                             </div>

                            </div>
                           
                           
                    
                        </div>
                     
                        </div>
                
               <a href="homepage.aspx">Back to Home Page</a>
                    </div>
                
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="card-body">
                           
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h3>Member List</h3>
                                        
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
                                    <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False">
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Library_Management_SystemConnectionString %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>
                                </div>
                            </div>
                           
                           
                        
                    
                        </div>
                     
                        </div>
                
             
                    </div>
                </div>
         </div>
         </div>

</asp:Content>
