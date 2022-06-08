<template>
  <div class="about">
    <h1>My Books</h1>
  </div>

  <div v-if="myBooks.length">
    <book
        :book="book"
        v-for="book in myBooks"
        :key="book.id">
    </book>
  </div>
</template>

<script lang="ts">
  import { Options, Vue } from 'vue-class-component';
  import IBook from "@/types/book";
  import BookService from "@/services/book-service";
  import Book from "@/components/Book.vue";

  const bookService = new BookService()

  @Options({
    name: 'MyBooks',
    components: { Book }
  })

  export default class MyBooks extends Vue {
    // data
    myBooks: IBook[] = [];

    // computed properties
    get bookCount() {
      return this.myBooks.length
    }

    // props

    // methods

    // lifecycle hooks
    created() {
      bookService.getAllBooks()
          .then(res => this.myBooks = res)
          .catch(err => console.error(err));
    }

    // watchers
  }
</script>
