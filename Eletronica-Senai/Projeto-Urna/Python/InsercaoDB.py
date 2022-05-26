# -*- coding: utf-8 -*-
"""
Created on Fri Mar 25 08:44:46 2022

@author: vinic

Request dados Firebase + inserção de votos 
"""
import requests
import pyodbc
import time

#function for get data for firebase
def GetData(UltimaTag):
    while(True):
        url_Firebase = "https://urnaeletronica-c4da3-default-rtdb.firebaseio.com/Urna1/Tag.json"
        Tag= int(requests.get(url_Firebase).content)
        if(Tag != UltimaTag): # verify if value in firebase is diferent i have in data
            url_Firebase = "https://urnaeletronica-c4da3-default-rtdb.firebaseio.com/Urna1/Voto.json" 
            content=int(requests.get(url_Firebase).content[1:3])
            
            Voto = content
            return Voto,Tag
        time.sleep(2)
        print("Não recolhido")
        
def InsertDb(Voto):
    # ///////////////////////////////////////////////////////////////////////////////
    # ///////////////////////  CREATE DATABASE SQL COMMANDS  /////////////////////////
    #create database VotosUrna
    # // criando o banco

    # // criando a tabela
    
    # create table VotosUrna1 
    # (
    #  id int identity(1,1) primary key,
    #  Voto int not null,
    # )
    #///////////////////////////////////////////////////////////////////////////////

    ServerSQL  = "DESKTOP-S4T02R7\SQLEXPRESS" # SERVER NAME
    MinhaDataBase = "VotosUrna" # my database name
    conexao = pyodbc.connect(driver = '{SQL Server}',  serve = ServerSQL,database=MinhaDataBase,Trusted_Connection=True) # connection ops
    cursor = conexao.cursor()
    cursor.execute(f"Insert into VotosUrna1 (Voto) values ({Voto})")
    cursor.commit()
    print("Inserido")


#init main code         
Tag = -1
while(True):
    Voto,Tag = GetData(Tag)
    InsertDb(Voto)
