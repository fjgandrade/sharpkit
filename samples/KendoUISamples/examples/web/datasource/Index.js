/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    var template = kendo.template($("#template").html());
    var movies =  [ {rank: 1, rating: 9.2, year: 1994, title: "The Shawshank Redemption"}, {rank: 2, rating: 9.2, year: 1972, title: "The Godfather"}, {rank: 3, rating: 9, year: 1974, title: "The Godfather = Part II"}, {rank: 4, rating: 8.9, year: 1966, title: "Il buono, il brutto, il cattivo."}, {rank: 5, rating: 8.9, year: 1994, title: "Pulp Fiction"}, {rank: 6, rating: 8.9, year: 1957, title: "12 Angry Men"}, {rank: 7, rating: 8.9, year: 1993, title: "Schindler\'s List"}, {rank: 8, rating: 8.8, year: 1975, title: "One Flew Over the Cuckoo\'s Nest"}, {rank: 9, rating: 8.8, year: 2010, title: "Inception"}, {rank: 10, rating: 8.8, year: 2008, title: "The Dark Knight"}];
    var dataSource = new kendo.data.DataSource(
    {
        data: movies,
        change: function ()
        {
            $("#movies tbody").html(kendo.render(template, this.view()));
        }
    });
    dataSource.read();
};
