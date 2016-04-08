app.service("bookService",function($http) {
    this.getBooks = function() {
        return $http.get("Home/GetAllBooks");
    };

    this.getBook=function(bookId) {
        var response = $http({
            method: "post",
            url: "Home/GetBookById",
            params: {
                id:JSON.stringify(bookId)
            }
        });
    }

    this.saveBook=function(book) {
        var response = $http({
            method: "post",
            url: "Home/Save",
            data: JSON.stringify(book),
            datatype:"json"
        });
    }

    this.DeleteBook=function(bookId) {
        var response = $http({
            method: "post",
            url: "Home/DeleteBook",
            params: {
                bookid:JSON.stringify(bookId)
            }
        });
    }
});