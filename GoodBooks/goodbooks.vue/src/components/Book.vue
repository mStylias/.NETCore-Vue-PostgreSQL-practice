<template>
  <div class="book-wrapper">
    {{ book.title }}
  </div>
</template>

<script lang="ts">
  import { Component, Vue } from 'vue-property-decorator';
  import IBook from "@/types/book";

  @Component({
    name: 'Book',
    components: {}
  })

  export default class Book extends Vue {
    book!: IBook;
  }
</script>

<style scoped lang="scss">
  .book-wrapper {
    margin: 0.8rem;
    padding: 0.4rem;
    border: 1px solid #555;
    border-radius: 1rem;
  }
</style>