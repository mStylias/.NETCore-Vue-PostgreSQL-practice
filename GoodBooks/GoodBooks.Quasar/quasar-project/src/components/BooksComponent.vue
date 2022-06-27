<template>
  <div>
    <h1> All books </h1>
    <div v-if="myBooks.length">
      {{ myBooks }}
    </div>
  </div>
</template>

<script lang="ts">
import {defineComponent, ref} from 'vue';
import IBook from 'src/types/Book';
import BookService from 'src/services/BookService';

export default defineComponent ({
  name: 'BooksComponent',

  setup() {
    const myBooks = ref<IBook[]>([]);
    const bookService = new BookService();

    bookService.getAllBooks().then(res => myBooks.value = res)
      .catch(err => console.error(err));

    return { myBooks }
  },

});



</script>

<style scoped>

</style>
