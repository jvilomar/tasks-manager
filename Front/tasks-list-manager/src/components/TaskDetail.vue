<template>
  <v-row justify="center">
    <v-col cols="12">
      <v-card elevation="2">
        <v-list-item two-line>
          <v-list-item-content>
            <v-list-item-title class="text-h5">
              {{ task.title }}
            </v-list-item-title>
            <v-list-item-subtitle class="caption">
              {{ task.isCompleted ? "Completed" : "Pending" }}
            </v-list-item-subtitle>
          </v-list-item-content>
        </v-list-item>
        <v-card-text>
          <v-row align="center">
            <v-col cols="8">
              {{ task.description }}
            </v-col>
          </v-row>
        </v-card-text>
        <v-divider></v-divider>
        <v-card-actions>
          <v-btn icon @click.stop="dialog = true">
            <v-icon>mdi-eye</v-icon>
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-col>
    <v-dialog v-model="dialog" persistent max-width="500">
        <v-card class="mx-auto" max-width="500">
          <v-card-title>{{task.title}}</v-card-title>
          <v-card-text class="text--primary">
            {{task.description}}
          </v-card-text>
          <v-divider></v-divider>
          <v-card-actions>
            <v-btn
              color="primary"
              @click='updateTask(task)'
            >
              Complete <v-icon right>mdi-check</v-icon>
            </v-btn>
          
            <v-btn
              color="success"
              @click="dialog = false"
            >
              Close <v-icon right>mdi-close</v-icon>
            </v-btn>
          </v-card-actions>
        </v-card>
    </v-dialog>
  </v-row>
</template>
<script>
import Vue from "vue";

export default Vue.extend({
  name: "TaskDetail",
  props: {
    task: {
      type: Object,
      required: true,
    },
  },
  data() {
    return {
      dialog: false
    };
  },
  mounted() {
    this.task.id;
    this.task.title;
    this.task.description;
    this.task.isCompleted;
  },
  methods: {
      updateTask : function(task) {
          this.$emit("updateTask", task);
          this.dialog = false;
      },
  },
});
</script>
