app.service("bookService",function($http) {
    this.getBooks = function() {
        return $http.get("/Book/GetAllBooks");
    };

    this.getBook=function(bookId) {
        var response = $http({
            method: "post",
            url: "/Book/GetBookById",
            params: {
                id:JSON.stringify(bookId)
            }
        });
        return response;
    }

    this.saveBook=function(book) {
        var response = $http({
            method: "post",
            url: "/Book/Save",
            data: JSON.stringify(book),
            datatype:"json"
        });
        return response;
    }

    this.DeleteBook=function(bookId) {
        var response = $http({
            method: "post",
            url: "/Book/DeleteBook",
            params: {
                bookid:JSON.stringify(bookId)
            }
        });
        return response;
    }
});