<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmbalagensAvenida.Default" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ContentPlaceholderID="HeaderContent" ID="HeaderContent" runat="server">
    <div class="header__chamada-acao">
        <h1 class="heading animate-fadein">Tudo o que <span class="underlined fonte-grossa">você</span> precisa</h1>
        <button class="header__button animate-fadein">Saiba mais</button>
    </div>
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
        <div class="animated-mouse"></div>

        <div class="row">
            <div class="col-1-of-3">
                <div class="card-seguimento">
                    <div class="card-seguimento--back">
                        <img class="card-seguimento__icone" src="/Imagens/icone-festa.svg" alt="Desenho representando uma festa" />
                        <p class="card-seguimento__texto--completo">Forma para doces, laços, fitas, fitilhos, pega balão, balões, lembranças, paineis decorativos, suporte para doces e cupcakes e papel bala, saia para cupcake, convites, velas e mais!</p>
                        <a class="card-seguimento__button card-seguimento__button--lined btn--center btn--white" href="#">Veja mais &rarr;</a>
                    </div>
                    <div class="card-seguimento--front">
                        <div class="card-seguimento__foto--1"></div>
                        <h3 class="card-seguimento__titulo">Artigos para festas</h3>
                        <div class="card-seguimento__conteudo">
                            <p class="card-seguimento__texto--curto">Forma para doces, laços, fitas, fitilhos, pega balão, balões, lembranças, paineis </p>
                            <button class="card-seguimento__button card-seguimento__button--lined" href="#">Passe o mouse &rarr;</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-1-of-3">
                <div class="card-seguimento">
                    <div class="card-seguimento--back">
                        <img class="card-seguimento__icone" src="/Imagens/icone-embalagem.svg" alt="Desenho representando uma festa" />
                        <p class="card-seguimento__texto--completo">Sacos, sacolas, embalagens para bolos e tortas, caixas para salgado, marmitas, papel jornal, papel celofane e outros. Copos, taças, pratos, cumbucas, talheres e muito mais.</p>
                        <a class="card-seguimento__button card-seguimento__button--lined btn--center btn--white" href="#">Veja mais &rarr;</a>
                    </div>
                    <div class="card-seguimento--front">
                        <div class="card-seguimento__foto--2"></div>
                        <h3 class="card-seguimento__titulo">Embalagens e Descartáveis</h3>
                        <div class="card-seguimento__conteudo">
                            <p class="card-seguimento__texto--curto">Sacos, sacolas, embalagens para bolos e tortas, caixas para salgado,</p>
                            <button class="card-seguimento__button card-seguimento__button--lined" href="#">Passe o mouse &rarr;</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-1-of-3">
                <div class="card-seguimento">
                    <div class="card-seguimento--back">
                        <img class="card-seguimento__icone" src="/Imagens/icone-doces.svg" alt="Desenho representando uma festa" />
                        <p class="card-seguimento__texto--completo">Doces, balas, pirulitos, chicletes, bombons, barquete, cereja, ameixa, damasco, nozes, frutas cristalizadas, uva passa, amendoim, marshmallows, artigos para sorvete, anilinas e corantes comestiveis e etc.</p>
                        <a class="card-seguimento__button card-seguimento__button--lined btn--center btn--white" href="#">Veja mais &rarr;</a>
                    </div>
                    <div class="card-seguimento--front">
                        <div class="card-seguimento__foto--3"></div>
                        <h3 class="card-seguimento__titulo">Comestíveis</h3>
                        <div class="card-seguimento__conteudo">
                            <p class="card-seguimento__texto--curto">Doces, balas, pirulitos, chicletes, bombons, barquete, cereja, ameixa, </p>
                            <button class="card-seguimento__button card-seguimento__button--lined" href="#">Passe o mouse &rarr;</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <section class="section-inclinada">
            <div class="section-inclinada__background">
                <div class="section-inclinada__conteudo">
                    <img ID="PeriodoAnoImg" runat="server" class="icone" src="/Imagens/ovo-pascoa.svg" alt="Alternate Text" />
                    <p ID="PeriodoAnoInfo" runat="server">
                        Temos uma linha diversificada em produtos descartáveis, chocolates e tudo que você precisa para confeccionar ovos de páscoa; ainda temos produtos para sorveteria e festas.
                    </p>
                </div>
            </div>
        </section>

        <div class="row">
            <div class="col-1-of-3"></div>
            <div class="col-1-of-3"></div>
            <div class="col-1-of-3"></div>
        </div>
        <div class="row">
            <div class="col-1-of-3"></div>
            <div class="col-1-of-3"></div>
            <div class="col-1-of-3"></div>
        </div>
</asp:Content>