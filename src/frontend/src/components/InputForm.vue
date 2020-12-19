<template>
  <v-row class="pt-3" justify="center">
    <v-form align="center">
      <v-text-field
        background-color="white"
        required
        v-on:keyup.enter="pushTaskToData()"
        clearable
        style="width:400px"
        v-model="task"
        outlined
        label="Add task"
      ></v-text-field>
    </v-form>
  </v-row>
</template>

<script>
export default {
  data() {
    return {
      task: '',
    };
  },
  methods: {
    pushTaskToData: function() {
      var currentTask = this.task.slice();
      if (!currentTask === null || currentTask.trim().length > 0) {
        this.$store.dispatch('createData', {
          Description: this.task,
        });
        this.task = '';
      }
    },
  },
};
</script>
