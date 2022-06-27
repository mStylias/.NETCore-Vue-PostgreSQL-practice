<script lang="ts">
import { defineComponent, ref } from 'vue';

export default defineComponent({
  name: 'MainLayout',

  setup () {
    return {
      search: ref(''),
      logo_url: ref('public/icons/logo.png')
    }
  }
});
</script>

<template>
  <q-layout view="lHh Lpr lFf">
    <q-header class="bg-titlebar" elevated>
      <div class="row q-pa-sm">
       <q-img
          :src="logo_url"
          spinner-color="white"
          style="max-width: 100px"
          :fit="'contain'"
        />

        <q-input class="q-mx-lg col" v-model="search" label="Search Books" style="min-width: 80px;">
          <q-icon class="q-mt-md" name="search" size="26px"/>
        </q-input>

        <div class="text-right self-center">
          <q-btn color="primary" label="Login/Register" />
          <q-btn class="q-ml-md" color="primary" label="Shopping Cart" />
        </div>

      </div>

      <q-tabs class="row route-tabs">
        <q-route-tab class="col" to="/" label="Home" />
        <q-route-tab class="col" to="/page1" label="Literature" />
        <q-route-tab class="col" to="/page2" label="Education" />
        <q-route-tab class="col" to="/page3" label="Children's Books" />
        <q-route-tab class="col" to="/page3" label="History" />
        <q-route-tab class="col" to="/page3" label="Sciences" />
      </q-tabs>

    </q-header>

    <q-page-container>
      <router-view />
    </q-page-container>
  </q-layout>
</template>

<style lang="scss" scoped>
  @import "src/css/app.scss";

  .bg-titlebar {
    background-color: $primary-light;
  }

  .route-tabs {
    color: $primary;
  }
</style>
