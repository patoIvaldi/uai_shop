<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container my-5">
        <h1 class="mb-4 text-center fw-bold">Bienvenido $user$</h1>
        
        <div class="row g-4">
            <div class="col-sm-6 col-md-4 col-lg-3">
                <div class="card shadow-sm h-100">
                    <img src="/imagenes/escritorio.jpg" class="card-img-top" alt="Escritorio">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title">Escritorio Moderno</h5>
                        <p class="card-text flex-grow-1">Ideal para tu espacio de estudio, madera sólida y diseño ergonómico.</p>
                        <a href="~/Escritorios" class="btn btn-primary mt-auto">Ver más</a>
                    </div>
                </div>
            </div>
            
            <div class="col-sm-6 col-md-4 col-lg-3">
                <div class="card shadow-sm h-100">
                    <img src="/imagenes/monitor.png" class="card-img-top" alt="Monitor">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title">Monitor Full HD</h5>
                        <p class="card-text flex-grow-1">Pantalla de 24 pulgadas, ideal para trabajos y estudio.</p>
                        <a href="~/Monitores" class="btn btn-primary mt-auto">Ver más</a>
                    </div>
                </div>
            </div>
            
            <div class="col-sm-6 col-md-4 col-lg-3">
                <div class="card shadow-sm h-100">
                    <img src="/imagenes/libro.png" class="card-img-top" alt="Libros">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title">Libros de Ingeniería</h5>
                        <p class="card-text flex-grow-1">Material actualizado para tus carreras técnicas y científicas.</p>
                        <a href="~/Libros" class="btn btn-primary mt-auto">Ver más</a>
                    </div>
                </div>
            </div>
            
            <div class="col-sm-6 col-md-4 col-lg-3">
                <div class="card shadow-sm h-100">
                    <img src="/imagenes/calculadora.jpg" class="card-img-top" alt="Calculadora">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title">Calculadora Científica</h5>
                        <p class="card-text flex-grow-1">Herramienta clave para tus cálculos y exámenes.</p>
                        <a href="~/Calculadoras" class="btn btn-primary mt-auto">Ver más</a>
                    </div>
                </div>
            </div>
            
            <!-- Agregá más cards según necesites -->
        </div>
    </div>

</asp:Content>
