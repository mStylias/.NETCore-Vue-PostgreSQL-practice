<template>
  <q-page class="row items-center justify-evenly">
    <BooksComponent title="BooksComponent" active>

    </BooksComponent>
  </q-page>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import BooksComponent from 'components/BooksComponent.vue';

export default defineComponent({
  name: 'IndexPage',
  components: { BooksComponent },

});
</script>
