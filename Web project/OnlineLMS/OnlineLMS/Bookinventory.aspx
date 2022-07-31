<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Bookinventory.aspx.cs" Inherits="OnlineLMS.Bookinventory" %>
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
                                            <h3>Book Detail</h3>
                                      
                                    </center>
                                </div>
                            </div>
                             <div class="row">
                                <div class="col">
                                    <center>
                                        <img width="100px" src="imgs/icons8-add-book-96.png" />
                                        
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
                                    <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                                </div>
                            </div>
                           
                            <div class="row">
                                <div class="col-md-4">
                                     <label >Book ISBN</label>
                                    <div class="form-group">
                                        
                                          <div class="input-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox3" placeholder="ISBN" runat="server"></asp:TextBox>
                                                 <asp:Button  class="btn btn-primary " ID="Button1" runat="server" Text="GO"   />
                                           </div>
                                        
                                    </div>
                                        </div>
                                <div class="col-md-8">
                                    <label  >Book Name</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox5" placeholder="Book Name" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                                
                               
                        </div>
                            <div class="row">
                                <div class="col-md-6">
                                     <label >Publisher Name</label>
                                    <div class="form-group">
                                        
                                          
                                        <asp:DropDownList class="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
                                        
                                           
                                        
                                    </div>
                                        </div>
                                <div class="col-md-6">
                                     <label >Author Name</label>
                                    <div class="form-group">
                                        
                                          
                                                
                                         <asp:DropDownList class="form-control" ID="DropDownList2" runat="server"></asp:DropDownList>
                                           
                                        
                                    </div>
                                        </div>
                               
                               
                        </div>
                            <div class="row">
                                <div class="col-md-12">
                                     <label >Book Edition</label>
                                   <asp:TextBox CssClass="form-control" ID="TextBox1" placeholder="Book Edition" runat="server"></asp:TextBox>
                                </div>
                            </div>
                             <div class="row">
                                <div class="col-md-4">
                                     <label >Actual Stock</label>
                                   <asp:TextBox CssClass="form-control" ID="TextBox2"  runat="server" TextMode="Number"></asp:TextBox>
                                </div>
                                  <div class="col-md-4">
                                     <label >Current Stock</label>
                                   <asp:TextBox CssClass="form-control" ID="TextBox4"  runat="server" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                </div>
                                  <div class="col-md-4">
                                     <label >Issued</label>
                                   <asp:TextBox CssClass="form-control" ID="TextBox6"  runat="server" TextMode="Number" ReadOnly="True"></asp:TextBox>
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
                                            <h3>Book List</h3>
                                        
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
                                    <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="bid" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField DataField="bid" HeaderText="bid" InsertVisible="False" ReadOnly="True" SortExpression="bid" />
                                            <asp:BoundField DataField="bname" HeaderText="bname" SortExpression="bname" />
                                            <asp:BoundField DataField="bauthor" HeaderText="bauthor" SortExpression="bauthor" />
                                            <asp:BoundField DataField="bpubl" HeaderText="bpubl" SortExpression="bpubl" />
                                            <asp:BoundField DataField="bpdate" HeaderText="bpdate" SortExpression="bpdate" />
                                            <asp:BoundField DataField="bprice" HeaderText="bprice" SortExpression="bprice" />
                                            <asp:BoundField DataField="bquantity" HeaderText="bquantity" SortExpression="bquantity" />
                                        </Columns>
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Library_Management_SystemConnectionString %>" SelectCommand="SELECT * FROM [Books]"></asp:SqlDataSource>
                                </div>
                            </div>
                           
                           
                        
                    
                        </div>
                     
                        </div>
                
             
                    </div>
                </div>
         </div>
         </div>
</asp:Content>
