<template>
  <v-app>
    <v-content>
      <v-row>
        <v-col justify-text="center">
          <home />
        </v-col>
      </v-row>
    </v-content>
  </v-app>
</template>
<script>
import Home from './components/Home.vue';

export default {
  name: 'App',
  components: {
    Home,
  },
};
</script>
