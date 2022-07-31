<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="authormanagement.aspx.cs" Inherits="OnlineLMS.authormanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="card-body">
                           
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h3>Author Detail</h3>
                                      
                                    </center>
                                </div>
                            </div>
                             <div class="row">
                                <div class="col">
                                    <center>
                                           <img width="100px" src="imgs/icons8-student-male-100.png" />
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <hr />
                                </div>
                            </div>
                           
                            <div class="row">
                                <div class="col-md-5">
                                     <label >Author ID</label>
                                    <div class="form-group">
                                        
                                           <div class="input-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox3" placeholder="Author ID" runat="server"></asp:TextBox>
                                         <asp:Button  class="btn btn-primary " ID="Button1" runat="server" Text="GO"   />
                                           </div>
                                        
                                    </div>
                                        </div>
                                <div class="col-md-7">
                                    <label  >Author Name</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox2" placeholder="Author Name" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                        </div>
                            <br />
                             <div class="row">
                                <div class="col-6">
                                    <div class="d-grid gap-2">
                                    <asp:Button class="btn btn-lg btn-success" ID="Button2"  runat="server" Text="Add" />
                                        </div>
                                </div>
                                 <div class="col-6">
                                     <div class="d-grid gap-2">
                                    <asp:Button class="btn btn-lg btn-warning" ID="Button3"  runat="server" Text="Update" />
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
                                            <h3>Author List</h3>
                                        
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
         </div>
</asp:Content>
