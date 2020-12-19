<template>
  <v-app class="grey lighten-4">
    <v-card class="mx-auto" max-width="400">
      <v-img class="white--text align-end" height="180px" :src="image">
        <span class="time">{{ currentTime }}</span>
      </v-img>
      <v-list v-for="task in tasks" :key="task.id">
        <v-list-item>
          <!-- Cool checkbox element from Vuesax framework -->
          <vs-checkbox
            v-model="task.done"
            @click="patch(task, task.id)"
            input-value="active"
            color="success"
          ></vs-checkbox>
          <v-list-item-content>
            <v-list-item-title :class="addColorAndLineThrough(task.done)">{{
              task.discription
            }}</v-list-item-title>
          </v-list-item-content>
          <transition name="fade">
            <v-icon
              v-if="task.done"
              @click="removeTask(task.id)"
              color="red"
              key="delete"
              >mdi-delete</v-icon
            >
          </transition>
          <transition name="fade"></transition>
        </v-list-item>
        <v-divider></v-divider>
      </v-list>
    </v-card>
    <input-form></input-form>
  </v-app>

  <!-- <v-btn @click="">Hello</v-btn> -->
</template>

<script>
import moment from 'moment';
import vsCheckbox from 'vuesax';
import Vue from 'vue';
import 'vuesax/dist/vuesax.css';
import InputForm from './InputForm';
import { mapActions } from 'vuex';
import { mapState } from 'vuex';

Vue.use(vsCheckbox);

export default {
  name: 'Home',
  components: {
    InputForm,
  },
  data: () => ({
    icons: ['mdi-delete ', 'mdi-delete'],
    currentTime: moment(new Date()).format('MMMM Do YYYY'),
    image:
      'https://media.istockphoto.com/photos/to-do-list-on-note-pad-with-coffee-and-pen-on-office-desk-picture-id863607936?k=6&m=863607936&s=612x612&w=0&h=ah7vkAcswYosdcuNZZKaVhmb6P9XSSkozVvhw4K47oM=',
  }),
  computed: mapState(['tasks', 'quotes']),

  methods: {
    ...mapActions(['getData', 'deleteData', 'patchData']),
    removeTask(id) {
      console.log(id);
      this.deleteData(id);
    },
    patch(state, id) {
      state.done = !state.done;
      this.patchData({
        State: state.done,
        Id: id,
      });
    },

    addColorAndLineThrough(task) {
      if (task) {
        return ['grey--text', 'line-through'];
      } else {
        return 'primary--text';
      }
    },

    updateCurrentTime() {
      this.currentTime = moment().format('MMMM Do YYYY');
    },
  },
  created() {
    this.getData();
  },
};
</script>

<style>
.col {
  margin: 0;
  padding: 0;
}
.line-through {
  text-decoration: line-through;
}
.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.5s;
}
.fade-enter, .fade-leave-active /* .fade-leave-active below version 2.1.8 */ {
  opacity: 0;
}
.time {
  margin: 10px;
  color: black;
  font-family: monospace;
  font-weight: bold;
}
</style>
