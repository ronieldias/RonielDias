#!/bin/bash

dotnet-aspnet-codegenerator controller -name ClientesController -m Cliente -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name ItensController -m Item -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name MarcasController -m Marca -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name NotasDeVendasController -m NotaDeVenda -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name PagamentosController -m Pagamento -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name PagamentosComCartaoController -m PagamentoComCartao -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name PagamentosComChequeController -m PagamentoComCheque -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name ProdutosController -m Produto -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name TiposDePagamentosController -m TipoDePagamento -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name TransportadorasController -m Transportadora -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
dotnet-aspnet-codegenerator controller -name VendedoresController -m Vendedor -dc MyDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

