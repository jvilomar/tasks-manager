<template>
  <v-app>
    <v-main>
      <task-list />
    </v-main>
  </v-app>
</template>

<script>
import Vue from "vue";
import TaskList from "./views/TaskList.vue";

export default Vue.extend({
  name: "App",
  components: {
    TaskList,
  },

  data: () => ({
    //
  }),
});
</script>