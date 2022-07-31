<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="OnlineLMS.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <section>
        <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="imgs/library_style_table_books_wooden_39317_1920x1080.jpg"style="height:200px" class="d-block w-100" alt="..."/>
    </div>
    <div class="carousel-item">
      <img src="imgs/library_inscription_sign_140549_300x168.jpg"style="height:200px" class="d-block w-100" alt="..."/>
    </div>
    <div class="carousel-item">
      <img src="imgs/books_library_shelves_138556_1920x1080.jpg"style="height:200px" class="d-block w-100" alt="..."/>
    </div>
      
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
   </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                   <center>
                        <h2>Our Features</h2>
                    <p><b>Our 3 Primary Features-</b></p>
                   </center>
            </div>
            </div>
             <div class="row">
                <div class="col-md-4">
                   <center>
                     <img width="150px" src="imgs/icons8-add-book-96.png" />
                    <h4>Digital BooK Inventory</h4>
                    <p class="text-justify">This Online Library System Store the Books Detail e.g. Book name,Author name,and some other Information of books</p>
                   </center>
            </div>
                  <div class="col-md-4">
                   <center>
                       <img  width="150px" src="imgs/search.gif" />
                    <h4>Search Books</h4>
                    <p class="text-justify">In our online Library management system the Student can Search Book with Book name, Author name and other</p>
                   </center>
            </div>
                  <div class="col-md-4">
                   <center>
                       <img  width="150px" src="imgs/view%20book%20gif1.gif" />
                    <h4>Isssue BooK</h4>
                    <p class="text-justify">Our main feature of this Online Library Management system is to issue Book to student </p>
                   </center>
            </div>
            </div>
        </div>
    </section>
</asp:Content>
