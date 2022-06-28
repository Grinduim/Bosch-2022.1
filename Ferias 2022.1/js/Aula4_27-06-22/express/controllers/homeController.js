exports.paginaInicial =(req, res)=> {res.send(`<formaction="/"method="POST">
Nome do cliente:<input type="text" name="qualquercoisa"><br>
Outro campo:<input type="text" name= "aquioutrocampo">
<button>Olámundo</button>
</form>`);
 };

 exports.paginaInicial = (req, res) => {
    res.render('index');};