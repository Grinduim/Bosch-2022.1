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
        url_Firebase = "https://projetournasenai-default-rtdb.firebaseio.com/Urna1/Tag.json"
        Tag= int(requests.get(url_Firebase).content)
        if(Tag != UltimaTag): # verify if value in firebase is diferent i have in data
            url_Firebase = "https://projetournasenai-default-rtdb.firebaseio.com/Urna1/Voto.json"
            conteudo=int(requests.get(url_Firebase).content[1:3])
            
            Voto = conteudo
            return Voto,Tag
        time.sleep(2)
        print("Não recolhido")
        
def InsertDb(Voto):
                print() 
                server  = "DESKTOP-S4T02R7\SQLEXPRESS"
                MinhaDataBase = "VotosUrna"
                username = "sa"
                pword = "admin"
                conexao = pyodbc.connect(driver = '{SQL Server}', host =server,database=MinhaDataBase,trusted_connection=True,user =username, password = pword)
                cursor = conexao.cursor()
                cursor.execute(f"Insert into VotosUrna1 (Voto) values ({Voto})")
                cursor.commit()
                print("Inserido")


#init main code         
Tag = -1
while(True):
    Voto,Tag = GetData(Tag)
    InsertDb(Voto)
